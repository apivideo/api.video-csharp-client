cp -R ../../templates/csharp/statics/.github ./
cp -R ../../templates/csharp/statics/* ./
mv src/ApiVideo ApiVideo
rm -Rf src
mv ApiVideo src