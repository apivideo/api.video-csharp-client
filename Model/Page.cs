
using System;
using System.Collections;
using System.Collections.Generic;
using VideoApiClient.Model;

public class Page<T> {
    public List<T> Items { get; }
    public int CurrentPage { get; }
    public int PageSize { get; }
    public int PagesTotal { get; }
    public int ItemsTotal { get; }
    public int CurrentPageItems { get; }
    public List<PaginationLink> Links { get; }
    public Func<Page<T>> GetNextPage { get; }
    private Page<T> that;

    public Page(List<T> items, Pagination pagination, Func<Page<T>> getNextPage) {
        this.Items = items;
        if (pagination != null) {
            this.CurrentPage = pagination.currentpage;
            this.PageSize = pagination.pagesize;
            this.PagesTotal = pagination.pagestotal;
            this.ItemsTotal = pagination.itemstotal;
            this.CurrentPageItems = pagination.currentpageitems;
            this.Links = pagination.links;
            this.GetNextPage = getNextPage;
            this.that = this;
        }
    }
}
