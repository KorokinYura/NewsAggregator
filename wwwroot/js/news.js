
let curComments = 0;

function loadMoreComments() {
    $.ajax({
        type: "POST",
        url: loadMoreComm,
        data: { id: newsId, curComments: curComments },

        success: function (comments) {
            for (let i = 0; i < comments.length; i++) {
                addComment(comments[i]);
            }
        }
    });
}

function addCommentAJAX() {
    var text = $("#text").val();
    $("#text").val = '';

    $.ajax({
        type: "POST",
        url: createComment,
        data: { newsId: newsId, text: text },

        success: writeComment
    });
}

function writeComment(comment) {
    $("#comments").prepend(
        formComment(comment)
    );
}

function addComment(comment) {
    $("#comments").append(
        formComment(comment)
    );
}

function formComment(comment) {
    let ret = checkForRemoveButton(comment.id) +
        '<div style="clear:both">' +
        '<div class="commentImageDiv">' +
        '<img class="commentImage" src="'
        + comment.imagePath +
        '"></div><div class="commentHead">'
        + comment.userName +
        '</div><div class="commentFooter">'
        + comment.date +
        '</div></div><div class="commentBody">'
        + comment.text +
        '</div><hr />';
    curComments++;

    $("#text").val("");

    return ret;
}

function removeCommentAJAX(id) {
    if (confirm('Are you sure you want to remove this comment?')) {
        $.ajax({
            type: "POST",
            url: removeComment,
            data: { commentId: id, newsId: newsId },

            success: function () {
                location.reload();
            }
        });
    }
}