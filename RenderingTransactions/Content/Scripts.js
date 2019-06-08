function toggleHiddenData(id) {
    if ($("#" + id).css("display") == "none") {
        $("#" + id).show();
    } else {
        $("#" + id).hide();
    }
}
