const obj = document.querySelector("#canvas");
const ctx = obj.getContext("2d");
ctx.fillStyle = "#FF0000";

ctx.beginPath();
const r = 10;


fetch("./data.json")
  .then(res => res.json())
  .then(res => {
    res.forEach(({ x, y }) => {
      ctx.fillRect(x, y, r, r)
    });

  })

