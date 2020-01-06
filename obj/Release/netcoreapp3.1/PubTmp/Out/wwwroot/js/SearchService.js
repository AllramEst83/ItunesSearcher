
var SearchService = {


    GetAllGenres: function () {

        var url = SearchService.GenresUrl;
        $.when(SearchService.GetJson(url)).then(function (data) {

            console.log(data);

            for (var i = 0; i < data.length; i++) {

                $('#genreSelect').append($('<option>').val(data[i].genreId).text(data[i].genreName));
            }
            return false;
        });
    },
    AddWish: function () {

        $(".tableContainer").on("click", ".addAppImage", function () {


            var id = $(this).data("appid");
            var trackname = $(this).data("trackname");
            var beskrivning = $(this).data("desc");
            var appImageUrl = $(this).attr("src");

            var data = {
                AppId: id,
                TrackName: trackname,
                Beskrivning: beskrivning,
                AppImageUrl: appImageUrl
            };

            $.ajax({
                url: "api/wishlist",
                type: "POST",
                data: JSON.stringify(data),
                contentType: "application/json",
                success: function (data) {

                    console.log(data);
                    SearchService.UpdateWishList(data);

                    alert(data.message);
                },
                error: function (jqXHR, textStatus, errorThrowns) {

                }
            });

        });
    },
    UpdateWishList: function (response) {
        var html = '<li class="list-group-item d-flex justify-content-between align-items-center" data-itemid="' + response.data.id + '">';
        html += response.data.trackName;
        html += '<div class="image-parent">';
        html += ' <img data-appId="' + response.data.appId + '" src="' + response.data.appImageUrl + '" class="img-fluid lessRoundEdges wishedhApp" alt="appImage">';
        html += '</div></li>';

        $(".list-group").append(html);

    },
    RemoveAppfromWishList: function (response) {
        console.log(response);
        $("li[data-itemid='" + response.data.id + "']").remove();
    },

    RemoveWishedApp: function () {

        $(".wishListBody").on('click', ".wishedhApp", function () {

            var id = $(this).data("appid");

            $.ajax({
                url: "api/wishlist",
                type: "DELETE",
                data: { id: JSON.stringify(id) },
                success: function (data) {

                    SearchService.RemoveAppfromWishList(data);

                    alert(data.message);

                },
                error: function (jqXHR, textStatus, errorThrowns) {

                    alert(`Something went wrong: ${textStatus}`);
                }


            });
        });

    },
    GetJson: function (url) {
        var deferred = jQuery.Deferred();

        $.getJSON(url, function (data) {

            console.log(url);

            deferred.resolve(data);


        });

        return deferred.promise();
    },
    GenresUrl: "api/genre",
    ItunesBaseUrl: "https://itunes.apple.com/",
    SearchUrl: function (
        term = "boardgames",
        country = "se",
        entity = "software",
        genreId = "6014",
        limit = "100") {

        console.log(`search?term=${term}&country=${country}&entity=${entity}&genreId=${genreId}&limit=${limit}`);

        var genreUrl = "";
        if (genreId === "0") {
            genreUrl = `search?term=${term}&country=${country}&entity=${entity}&limit=${limit}`;
        } else {
            genreUrl = `search?term=${term}&country=${country}&entity=${entity}&genreId=${genreId}&limit=${limit}`;
        }

        return genreUrl;
    },
    LookupUrl: "https://itunes.apple.com/lookup?id=",
    GetFrontPageApps: function () {
        $.blockUI();

        var url = "https://itunes.apple.com/WebObjects/MZStoreServices.woa/ws/charts?cc=se&g=6014&name=PaidApplications";
        var lookUpUrl = SearchService.LookupUrl;
        $.when(SearchService.GetJson(url)).then(function (data) {

            console.log(data);
            var resultCount = data.resultIds.length - 1;
            var counter = 0;

            for (var i = 0; i < data.resultIds.length; i++) {
                lookUpUrl += data.resultIds[i];

                if (resultCount !== counter) {
                    lookUpUrl += ",";
                }
                counter++;
            }

            console.log(lookUpUrl);
            $.when(SearchService.AjaxCall(lookUpUrl)).then(function (data) {

                var shapedData = SearchService.ShapeData(data);
                var settings = {
                    data: shapedData,
                    columns: [
                        { data: 'Id', className: "dt-body-center" },
                        { data: 'Namn', render: SearchService.GetAppName, className: "dt-body-center" },
                        { data: 'Beskrivning', className: "dt-body-center" },
                        { data: 'Bild', render: SearchService.GetImage, className: "dt-body-center" }
                    ],
                    "columnDefs": [
                        //{ "className": "dt-center", "targets": "_all" },                    
                        { "width": "12%", "targets": 3 },
                        { targets: 2, visible: false },
                        { targets: 0, visible: false }
                    ],
                    responsive: true,
                    "scrollY": "500px",
                    dom: 'Bfrtip',
                    //buttons: {
                    //    buttons: [
                    //        { extend: 'colvis', className: 'btn btn-success' },
                    //        { extend: 'pageLength', className: 'btn btn-success' }
                    //    ],
                    //    dom: {
                    //        button: {
                    //            className: 'btn'
                    //        }
                    //    }
                    //},
                    buttons: [
                        'colvis',
                        'pageLength'
                    ],
                    "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]]
                };

                $("#itunesContentTable").DataTable(settings);

                SearchService.GetAllGenres();


                $(".ContentDiv").slideDown();

                console.log(data);
                $.unblockUI();
            });
        });

        return;
    },
    GetAppName: function (data, type, full, meta) {
        return "<a id='tableAppId' href='#' data-appid=" + full.Id + " data-toggle='modal' data-target='#appPopUp'>" + data + "</a>";
    },
    ShapeData: function (data) {
        var returnData = [];

        for (var i = 0; i < data.results.length; i++) {

            var item = {
                Id: data.results[i].trackId,
                Namn: data.results[i].trackName,
                Beskrivning: data.results[i].description,
                Bild: data.results[i].artworkUrl512
            };

            returnData.push(item);
        }

        console.log(returnData);
        return returnData;
    },
    GetImage: function (data, type, full, meta) {

        var image = '<img data-desc="' + full.Beskrivning + '" data-trackname="' + full.Namn + '" data-appid="' + full.Id + '" class="img-fluid roundEdges addAppImage"  src="' + data + '" />';
        return image;
    },
    OpenAppModal: function () {
        $(".tableContainer").on('click', "#itunesContentTable a", function () {

            console.log($(this).data("appid"));

            var id = $(this).data("appid");
            var lookupUrl = SearchService.LookupUrl;
            lookupUrl += id;

            console.log(lookupUrl);

            $.when(SearchService.AjaxCall(lookupUrl)).then(function (data) {

                console.log(data);

                $(".modal-title").empty();
                $(".dialogCardBody").empty();
                $(".card-img-top").attr("src", "");

                $(".modal-title").text(data.results[0].trackName);
                $(".dialogCardBody").text(data.results[0].description);
                $(".card-img-top").attr("src", data.results[0].artworkUrl512);
                // $(".modal-title").text(data.results[0].trackName);

            });

        });
    },
    SearchItunes: function () {
        $("#searchButton").on("click", function () {
            $.blockUI();

            var userInput = $("#searchInput").val().trim();
            var genreId = $("#genreSelect").val();

            var query = SearchService.SearchUrl(term = userInput,
                country = "se",
                entity = "software",
                genreId = genreId,
                limit = "100");

            console.log(query);
            var url = SearchService.ItunesBaseUrl + query;

            console.log(url);

            $.when(SearchService.AjaxCall(url)).then(function (data) {
                if (data.resultCount !== 0) {
                    $("#itunesContentTable tbody").empty();

                    var shapedData = SearchService.ShapeData(data);

                    var table = $("#itunesContentTable").DataTable();
                    table.clear();
                    table.rows.add(shapedData).draw();
                } else {
                    alert("Nothing to show!");
                }

                 $.unblockUI();
            });

        });


    },
    AjaxCall: function (url) {

        var deferred = jQuery.Deferred();

        $.ajax({
            url: url,
            success: function (data, textStatus, jqXHR) {

                //var parsedData = JSON.parse(data);
                console.log(data);

                deferred.resolve(data);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(`statusText: ${jqXHR.statusText}, textStatus: ${textStatus}, errorThrown: ${errorThrown}, Url: ${url}`);

            },
            type: "GET",
            dataType: "jsonp",
            //contentType: "application/json",
            headers: { 'Access-Control-Allow-Origin': 'https://itunessearcher.azurewebsites.net/' },
            crossDomain: true

        });

        return deferred.promise();
    }
};