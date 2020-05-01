$("#submit-button").click(function (e) {
    $(".modal").show();

    $("#User-name-box").text(`Hi! ${$("#name-box").val()}`)

    e.preventDefault();
});

$(".modal").hide();

$(".closing").click(function () {
    $(".modal").hide();
})