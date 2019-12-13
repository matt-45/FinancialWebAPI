$(document).ready(function () {


    console.log("New page loaded")

    $("#logo").removeAttr("href")
    $("#logo").addClass("navbar-brand")
    $("#header").addClass("navbar-header")
    $(".swagger-ui-wrap").addClass("navbar-collapse")
    $(".logo_image").remove()
    $("#api_info").remove()
    $(".input").remove()
    //$("#logo").html("&nbsp; &nbsp; Financial Portal API")
    $("#logo").text("Financial Portal API")
    $("title").text("Financial Portal API")


    $("#validator").remove()
    $(".footer").remove()



})