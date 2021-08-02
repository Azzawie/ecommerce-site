$(function () {
    $('.blankAdElement').on('click', function () {
        $('[id*="adTitle"]').val($(this).text());
    });

    $('[id*="adTitle"]').on('blur', function () {
        setTimeout(function () {
            EmptyAndHideAdList();
        }, 150);
    });

    $('[id*="adTitle"]').on('input', function () {
        var userInput = $(this).val();
        if (userInput) {
            var settings = {
                "url": `https://localhost:44302/api/ads/search/${userInput}`,
                "method": "GET",
                "timeout": 0,
            };

            $.ajax(settings)
                .done(function (response) {
                    if (response.length > 0) {
                        SetAdList(response);
                    } else {
                        EmptyAndHideAdList()
                    }
                })
                .fail(function (response) {
                    EmptyAndHideAdList()
                });
        } else {
            EmptyAndHideAdList()
        }
    });

    function SetAdList(arr) {
        var adSearchObject = $('[id*="AdSearch"]');
        var adList = adSearchObject.find('[id*="AdList"]');
        var blankAd = adSearchObject.find('[id*="BlankAd"]');
        adList.empty();
        arr.forEach(row => {
            tag = `<div class='blankAdElement'>
                        <a href='https://localhost:44302/ShowAd?id=${row.Id}'>${row.Title}</a>
                   </div>`

            adList.append(
                $(tag)
            );
        });

        if (arr.length > 0) {
            adSearchObject.removeClass('d-none');
            blankAd.addClass('d-none');
        } else {
            EmptyAndHideAdList()
        }
    }

    function EmptyAndHideAdList() {
        var adSearchObject = $('[id*="AdSearch"]');
        var adList = adSearchObject.find('[id*="AdList"]');
        adList.empty();
        adSearchObject.addClass('d-none');
    }
});