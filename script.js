function result(catsName) {
  if (catsName.includes("ee", "i", "y")) {
    console.log("Perfect");
  }
  if (!catsName.includes("ee", "i", "y") && catsName.includes("a", "e")) {
    console.log("Good");
  }
  if (!catsName.includes("ee", "i", "y") && !catsName.includes("a", "e")) {
    console.log("Bad");
  }
}

result(document.getElementById("nameInput").value);
