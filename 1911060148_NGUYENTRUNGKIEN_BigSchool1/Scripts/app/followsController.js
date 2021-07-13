var FollowsController = function () {
    var button;
    var init = function () {
        $(".js-toggle-follow").click(toggleFollow);
    };
    var toggleFollow = function (e) {
        button = $(e.target);
        if (button.hasClass("btn-default")) {
            createFollow();
        }
        else {
            deleteFollow();
        }
    };
    var createFollow = function () {
        $.post("/api/followings", { followeeId: button.attr("data-user-id") })
            .done(done)
            .fail(fail);
    };
    var deleteFollow = function () {
        $.ajax({
            url: "/api/followings/" + button.attr("data-user-id"),
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };
    var done = function () {
        var text = (button.text() == "Unfollow") ? "Following" : "Unfollow";
        button.toggleClass("btn-default").toggleClass("btn-danger").text(text);
    };
    var fail = function () {
        alert("Something Failed!");
    };
    return {
        init: init
    }
}();