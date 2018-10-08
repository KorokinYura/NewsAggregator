function askForDelete(id) {
    if (confirm('Are you sure you want to remove this news?')) {
        $.ajax({
            type: "POST",
            url: removeANews,
            data: { id: id },

            success: function () {
                location.reload();
            }
        });
    }
}
