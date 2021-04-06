const catsName = document.getElementById("nameInput").value;

function result(catsName) {
  for (cat in catsName) {
    if (catsName.match(/ee|i|y/gi)) {
      console.log("Perfect");
      break;
    } else if (catsName.match(/a|e/gi)) {
      console.log("Good");
      break;
    } else {
      console.log("Bad");
    }
  }
}

result(catsName);
