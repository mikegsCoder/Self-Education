// $(document).ready(() => {
//   $("#content").html("<h1>Hello TypeScript!</h1>");
// });

$(() => {
  $("#content").html("<h1>Hello TypeScript!</h1>");
});

$(() => {
  $("#alertBtn").click((e) => { $("#content").html("<h2>Hello World!</h2>"); });
});