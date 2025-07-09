$(document).ready(function () {
  $(".gallery-item .gallery-links").hover(
    function () {
      $(this).stop().fadeTo(400, 1);
    },
    function () {
      $(this).stop().fadeTo(400, 0);
    }
  );
});
$(document).ready(function () {
  $(".card").hover(
    function () {
      // On mouse enter
      $(this).stop().animate(
        {
          backgroundColor: "rgba(12, 12, 61, 1)",
          color: "white",
        },
        800
      );
    },
    function () {
      $(this).stop().animate(
        {
          backgroundColor: "#fff",
          color: "#000",
        },
        800
      );
    }
  );
});
