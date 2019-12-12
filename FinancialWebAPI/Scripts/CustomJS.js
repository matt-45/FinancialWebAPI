$(document).ready(function () {


    console.log("New page loaded")

    $("#logo").removeAttr("href")
    $(".logo_image").remove()
    $("#api_info").remove()
    $(".input").remove()
    $("#logo").html("&nbsp; &nbsp; Financial Portal API")
    $("title").text("Financial Portal API")



})