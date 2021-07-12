var FollowsController = function () {
    var link;
    var init = function () {
        $(".js-toggle-follow").click(toggleFollow);
    };
    var toggleFollow = function (e) {
        link = $(e.target);
        if (link.hasClass("text-danger")) {
            createFollow();
        }
        else {
            deleteFollow();
        }
    };
    var createFollow = function () {
        $.post("/api/followings", { followeeId: link.attr("data-user-id") })
            .done(done)
            .fail(fail);
    };
    var deleteFollow = function () {
        $.ajax({
            url: "/api/followings/" + link.attr("data-user-id"),
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };
    var done = function () {
        var text = (link.text() == "Following") ? "Follow?" : "Following";
        button.toggleClass("text-danger").toggleClass("text-info").text(text);
    };
    var fail = function () {
        alert("Something Failed!");
    };
    return {
        init: init
    }
}();