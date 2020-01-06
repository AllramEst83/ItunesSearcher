
var SearchService = {

    ItunesBaseUrl: "https://itunes.apple.com/",
    Search: "search?term=guns&country=se&entity=software",
    AjaxCall: function (url) {

        var deferred = jQuery.Deferred();

        $.ajax({
            url: url,
            success: function (data, textStatus, jqXHR) {

                var parsedData = JSON.parse(data);
                console.log(parsedData);

                deferred.resolve(parsedData);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(`jqXHR: ${jqXHR}, textStatus: ${textStatus}, errorThrown: ${errorThrown}`);
            }
        });

        return deferred.promise();
    },
    ShapeData: function (data) {
        var returnData = [];

        for (var i = 0; i < data.results.length; i++) {

            var item = {
                Namn: data.results[i].trackName,
                Beskrivning: data.results[i].trackId,
                Bild: data.results[i].artworkUrl512
            };

            returnData.push(item);
        }

        console.log(returnData);
        return returnData;
    },
    GetImage: function (data, type, full, meta) {
        return '<img style="max-width:50%;border-radius:10%;"   src="' + data + '" />';
    },
    SearchItunes: function () {
        $("#searchButton").on("click", function () {
            var userInput = $("#searchInput").val();
            var serachterm = `search?term=${userInput}&country=se&entity=software`;
            var url = SearchService.ItunesBaseUrl + serachterm;

            console.log(url);

            $.when(SearchService.AjaxCall(url)).then(function (data) {

                $("#itunesContentTable tbody").empty();

                var shapedData = SearchService.ShapeData(data);

                var table = $("#itunesContentTable").DataTable();
                table.clear();
                table.rows.add(shapedData).draw();
            });
        });
    },
    InitApp: function () {

        $.when(SearchService.AjaxCall(SearchService.ItunesBaseUrl + SearchService.Search)).then(function (data) {

            var shapedData = SearchService.ShapeData(data);

            $("#itunesContentTable").DataTable({
                data: shapedData,
                columns: [
                    { data: 'Namn' },
                    { data: 'Beskrivning' },
                    { data: 'Bild', render: SearchService.GetImage }
                ]
            });

        });

    }
};