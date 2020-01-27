// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification

var SearchService = SearchService || {};

$(function () {

    SearchService.GetFrontPageApps();
    SearchService.SearchItunes();
    SearchService.OpenAppModal();
    SearchService.AddWish();
    SearchService.RemoveWishedApp();
    SearchService.ListenToKeyPress();

});