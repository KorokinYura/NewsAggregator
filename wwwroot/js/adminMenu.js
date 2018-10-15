function addModerator() {
    let userName = $("#addModer").val();
    
    $.ajax({
        type: "POST",
        url: addModer,
        data: { userName: userName },

        success: function () {
            location.reload();
        },

        error: function () {
            alert("There is not a user with name " + userName)
        }
    });
}

function removeModerator() {
    let userName = $("#removeModer").val();

    $.ajax({
        type: "POST",
        url: removeModer,
        data: { userName: userName },

        success: function () {
            location.reload();
        },

        error: function () {
            alert("There is not a user with name " + userName)
        }
    });
}
