﻿using VideoApiClient.Api;
using FluentAssertions;
using VideoApiClient.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApiClient.Model;
using System.Collections.Generic;
using System.IO;
using Moq;

namespace VideoApiTests.Client
{
    [TestClass]
    public class VideosApiTest : AbstractApiTest
    {
        private VideosApi api = apiClientMock.Videos();

        private static string PAYLOADS_PATH = "";

        #region DELETE
        private void InitDeleteTests()
        {
            PAYLOADS_PATH = "/payloads/videos/delete/";
        }

        [TestMethod]
        public void DeleteRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");

            api.Invoking(x => x.delete(null))
                                .Should()
                                .Throw<ApiException>()
                                .WithMessage("Missing required parameter 'videoId' when calling VideosApi->delete");
            api.Invoking(x => x.delete("vi4k0jvEUuaTdRAEjQ4Jfrgz"))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void DeleteResponseWithStatus404Test()
        {
            InitDeleteTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.delete("vi4k0jvEUuaTdRAEjQ4Jfrgz"))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region GET
        private void InitGetTests()
        {
            PAYLOADS_PATH = "/payloads/videos/get/";
        }

        [TestMethod]
        public void GetRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");

            api.Invoking(x => x.get(null))
                                .Should()
                                .Throw<ApiException>()
                                .WithMessage("Missing required parameter 'videoId' when calling VideosApi->get");
            api.Invoking(x => x.get("vi4k0jvEUuaTdRAEjQ4Jfrgz"))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void GetResponseWithStatus200Test()
        {
            InitGetTests();
            answerOnAnyRequest(200, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Video res = api.get("videoId_example");

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("2019-12-16T08:25:51+00:00");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
            
        }

        [TestMethod]
        public void GetResponseWithStatus404Test() 
        {
            InitGetTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.get("videoId_example"))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region GETSTATUS
        private void InitGetStatusTests()
        {
            PAYLOADS_PATH = "/payloads/videos/getStatus/";
        }

        [TestMethod]
        public void GetStatusRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");

            api.Invoking(x => x.getVideoStatus(null))
                                .Should()
                                .Throw<ApiException>()
                                .WithMessage("Missing required parameter 'videoId' when calling VideosApi->getVideoStatus");
            api.Invoking(x => x.getVideoStatus("vi4k0jvEUuaTdRAEjQ4Jfrgz"))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void GetStatusResponseWithStatus200Test()
        {
            InitGetStatusTests();
            answerOnAnyRequest(200, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Videostatus res = api.getVideoStatus("vi4k0jvEUuaTdRAEjQ4Jfrgz");

            res.ingest.Should().NotBeNull();
            res.ingest.status.Should().Be("uploaded");
            res.ingest.filesize.Should().Be(273579401);
            res.ingest.receivedbytes.Should()
                                    .BeEquivalentTo(new List<BytesRange>()
                                    {
                                        new BytesRange(){ from=0, to=134217727, total=273579401 },
                                        new BytesRange(){ from=134217728, to=268435455, total=273579401 },
                                        new BytesRange(){ from=268435456, to=273579400, total=273579401 },
                                    });
            res.encoding.Should().NotBeNull();
            res.encoding.playable.Should().BeTrue();
            res.encoding.qualities.Should()
                                    .BeEquivalentTo(new List<Quality>()
                                    {
                                        new Quality(){ _quality = "360p", status = "encoded" },
                                        new Quality(){ _quality = "480p", status = "encoded" },
                                        new Quality(){ _quality = "720p", status = "encoded" },
                                        new Quality(){ _quality = "1080p", status = "encoding" },
                                        new Quality(){ _quality = "2160p", status = "waiting" }
                                    });
            res.encoding.metadata.Should().NotBeNull();
            res.encoding.metadata.width.Should().Be(424);
            res.encoding.metadata.height.Should().Be(240);
            res.encoding.metadata.bitrate.Should().Be((decimal)411.218);
            res.encoding.metadata.duration.Should().Be(4176);
            res.encoding.metadata.framerate.Should().Be(24);
            res.encoding.metadata.samplerate.Should().Be(48000);
            res.encoding.metadata.videocodec.Should().Be("h264");
            res.encoding.metadata.audiocodec.Should().Be("aac");
            res.encoding.metadata.aspectratio.Should().Be("16/9");

        }

        [TestMethod]
        public void GetStatusResponseWithStatus404Test()
        {
            InitGetStatusTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.getVideoStatus("videoId_example"))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region LIST
        private void InitListTests()
        {
            PAYLOADS_PATH = "/payloads/videos/list/";
        }

        [TestMethod]
        public void ListResponseWithStatus200Test()
        {
            InitListTests();
            answerOnAnyRequest(200, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Page<Video> page = api.list().execute();

            page.CurrentPage.Should().Be(1);
            page.PageSize.Should().Be(25);
            page.PagesTotal.Should().Be(1);
            page.CurrentPageItems.Should().Be(11);
            page.Items.Should().HaveCount(3);

            Video res = page.Items[0];

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Prklg");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining the string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("2019-12-16T08:25:51+00:00");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/c188ed58-3403-46a2-b91b-44603d10b2c9/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/c188ed58-3403-46a2-b91b-44603d10b2c9?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/c188ed58-3403-46a2-b91b-44603d10b2c9?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void ListResponseWithStatus400Test()
        {
            InitListTests();
            answerOnAnyRequest(400, readResourceFile(PAYLOADS_PATH + "responses/400.json"));

            api.Invoking(x => x.list().execute())
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 400)
                                .WithMessage("This parameter is out of the allowed range of values.");
        }
        #endregion

        #region UPDATE
        private void InitUpdateTests()
        {
            PAYLOADS_PATH = "/payloads/videos/update/";
        }

        [TestMethod]
        public void UpdateRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");

            api.Invoking(x => x.update("1234", null))
                                .Should()
                                .Throw<ApiException>()
                                .WithMessage("Missing required parameter 'videoUpdatePayload' when calling VideosApi->update");


            api.Invoking(x => x.update(null, new VideoUpdatePayload()))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoId' when calling VideosApi->update");

            api.Invoking(x => x.update("vi4k0jvEUuaTdRAEjQ4Jfrgz",new VideoUpdatePayload()))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void UpdatetResponseWithStatus200Test()
        {
            InitUpdateTests();
            answerOnAnyRequest(200, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Video res = api.update("vi4k0jvEUuaTdRAEjQ4Jfrgz", new VideoUpdatePayload());

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining the string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("2019-12-16T08:25:51+00:00");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void UpdateResponseWithStatus400Test()
        {
            InitUpdateTests();
            answerOnAnyRequest(400, readResourceFile(PAYLOADS_PATH + "responses/400.json"));

            api.Invoking(x => x.update("vi4k0jvEUuaTdRAEjQ4Jfrgz", new VideoUpdatePayload()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 400)
                                .WithMessage("This attribute must be a ISO-8601 date.");
        }

        [TestMethod]
        public void UpdateResponseWithStatus404Test()
        {
            InitUpdateTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.update("vi4k0jvEUuaTdRAEjQ4Jfrgz", new VideoUpdatePayload()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region PICKTHUMBNAIL
        private void InitPickThumbnailTests()
        {
            PAYLOADS_PATH = "/payloads/videos/pickThumbnail/";
        }

        [TestMethod]
        public void PickThumbnailRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");
            var tnpPayload = new VideoThumbnailPickPayload() { timecode = "10:10:10" };
            var videoId = "vi4k0jvEUuaTdRAEjQ4Jfrgz";

            api.Invoking(x => x.pickThumbnail(null, tnpPayload))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoId' when calling VideosApi->pickThumbnail");

            api.Invoking(x => x.pickThumbnail(videoId, null))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoThumbnailPickPayload' when calling VideosApi->pickThumbnail");

            api.Invoking(x => x.pickThumbnail(videoId, new VideoThumbnailPickPayload()))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoThumbnailPickPayload.timecode' when calling VideosApi->pickThumbnail");

            api.Invoking(x => x.pickThumbnail(videoId, tnpPayload))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void PickThumbnailResponseWithStatus200Test()
        {
            InitPickThumbnailTests();
            answerOnAnyRequest(200, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Video res = api.pickThumbnail("vi4k0jvEUuaTdRAEjQ4Jfrgz", new VideoThumbnailPickPayload() { timecode = "10:10:10" });

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("4665-07-14T23:36:18.598Z");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void PickThumbnailResponseWithStatus404Test()
        {
            InitPickThumbnailTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.pickThumbnail("vi4k0jvEUuaTdRAEjQ4Jfrgz", new VideoThumbnailPickPayload() { timecode = "10:10:10" }))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region CREATE
        private void InitCreateTests()
        {
            PAYLOADS_PATH = "/payloads/videos/create/";
        }

        [TestMethod]
        public void CreateRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");

            api.Invoking(x => x.create(null))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoCreatePayload' when calling VideosApi->create");

            api.Invoking(x => x.create(new VideoCreatePayload()))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoCreatePayload.title' when calling VideosApi->create");

            api.Invoking(x => x.create(new VideoCreatePayload() { title = "title" }))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void CreateResponseWithStatus201Test()
        {
            InitCreateTests();
            answerOnAnyRequest(201, readResourceFile(PAYLOADS_PATH + "responses/201.json"));

            Video res = api.create(new VideoCreatePayload() { title = "title" });

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl4k0jvEUuaTdRAEjQ4Jfrgz");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining the string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("4665-07-14T23:36:18.598Z");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void CreateResponseWithStatus400Test()
        {
            InitCreateTests();
            answerOnAnyRequest(400, readResourceFile(PAYLOADS_PATH + "responses/400.json"));

            api.Invoking(x => x.create(new VideoCreatePayload() { title = "title" }))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 400)
                                .WithMessage("This attribute is required.");
        }
        #endregion

        #region UPLOAD
        private void InitUploadTests()
        {
            PAYLOADS_PATH = "/payloads/videos/upload/";
        }

        [TestMethod]
        public void UploadRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");
            api.Invoking(x => x.upload(null, new MemoryStream()))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoId' when calling VideosApi->upload");

            api.Invoking(x => x.upload("1234",null))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'file' when calling VideosApi->upload");


            api.Invoking(x => x.upload("videoId_example", new MemoryStream()))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void UploadResponseWithStatus201Test()
        {
            InitUploadTests();
            answerOnAnyRequest(201, readResourceFile(PAYLOADS_PATH + "responses/201.json"));

            Video res = api.upload("vi4k0jvEUuaTdRAEjQ4Jfrgz", new MemoryStream());

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining the string theory.");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("4665-07-14T23:36:18.598Z");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void UploadResponseWithStatus400Test()
        {
            InitUploadTests();
            answerOnAnyRequest(400, readResourceFile(PAYLOADS_PATH + "responses/400.json"));

            api.Invoking(x => x.upload("videoId_example", new MemoryStream()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 400)
                                .WithMessage("The source of the video is already uploaded.");
        }

        [TestMethod]
        public void UploadResponseWithStatus404Test()
        {
            InitUploadTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.upload("videoId_example", new MemoryStream()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion

        #region UPLOADTHUMBNAIL
        private void InitUploadThumbnailTests()
        {
            PAYLOADS_PATH = "/payloads/videos/uploadThumbnail/";
        }

        [TestMethod]
        public void UploadThumbnailRequiredParametersTest()
        {
            answerOnAnyRequest(201, "{}");
            api.Invoking(x => x.uploadThumbnail(null, new MemoryStream()))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'videoId' when calling VideosApi->uploadThumbnail");

            api.Invoking(x => x.uploadThumbnail("1234", null))
                                            .Should()
                                            .Throw<ApiException>()
                                            .WithMessage("Missing required parameter 'file' when calling VideosApi->uploadThumbnail");


            api.Invoking(x => x.uploadThumbnail("videoId_example", new MemoryStream()))
                                .Should()
                                .NotThrow();
        }

        [TestMethod]
        public void UploadThumbnailResponseWithStatus200Test()
        {
            InitUploadThumbnailTests();
            answerOnAnyRequest(201, readResourceFile(PAYLOADS_PATH + "responses/200.json"));

            Video res = api.uploadThumbnail("vi4k0jvEUuaTdRAEjQ4Jfrgz", new MemoryStream());

            res.videoid.Should().Be("vi4k0jvEUuaTdRAEjQ4Jfrgz");
            res.playerid.Should().Be("pl45KFKdlddgk654dspkze");
            res.title.Should().Be("Maths video");
            res.description.Should().Be("An amazing video explaining the string theory");
            res._public.Should().BeFalse();
            res.panoramic.Should().BeFalse();
            res.mp4support.Should().BeTrue();
            res.tags.Should().BeEquivalentTo(new List<string>() { "maths", "string theory", "video" });
            res.metadata.Should().BeEquivalentTo(new List<Metadata>() { new Metadata() { key = "Author", value = "John Doe" }, new Metadata() { key = "Format", value = "Tutorial" } });
            res.publishedat.Should().Be("2020-07-14T23:36:18.598Z");
            res.source.Should().NotBeNull();
            res.source.uri.Should().Be("/videos/vi4k0jvEUuaTdRAEjQ4Jfrgz/source");
            res.assets.Should().NotBeNull();
            res.assets.hls.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/hls/manifest.m3u8");
            res.assets.iframe.Should().Be("<iframe src=\"//embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae\" width=\"100%\" height=\"100%\" frameborder=\"0\" scrolling=\"no\" allowfullscreen=\"\"></iframe>");
            res.assets.mp4.Should().Be("https://cdn.api.video/vod/vi4k0jvEUuaTdRAEjQ4Jfrgz/token/8fd70443-d9f0-45d2-b01c-12c8cfc707c9/mp4/720/source.mp4");
            res.assets.player.Should().Be("https://embed.api.video/vi4k0jvEUuaTdRAEjQ4Jfrgz?token=831a9bd9-9f50-464c-a369-8e9d914371ae");
            res.assets.thumbnail.Should().Be("https://cdn.api.video/stream/831a9bd9-9f50-464c-a369-8e9d914371ae/thumbnail.jpg");
        }

        [TestMethod]
        public void UploadThumbnailResponseWithStatus400Test()
        {
            InitUploadThumbnailTests();
            answerOnAnyRequest(400, readResourceFile(PAYLOADS_PATH + "responses/400.json"));

            api.Invoking(x => x.upload("videoId_example", new MemoryStream()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 400)
                                .WithMessage("Only [jpeg, jpg, JPG, JPEG] extensions are supported.");
        }

        [TestMethod]
        public void UploadThumbnailResponseWithStatus404Test()
        {
            InitUploadThumbnailTests();
            answerOnAnyRequest(404, readResourceFile(PAYLOADS_PATH + "responses/404.json"));

            api.Invoking(x => x.upload("videoId_example", new MemoryStream()))
                                .Should()
                                .Throw<ApiException>()
                                .Where(x => x.ErrorCode == 404)
                                .WithMessage("The requested resource was not found.");
        }
        #endregion
    }
}