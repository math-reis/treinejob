const input = document.getElementById("nameInput");
const output = document.getElementById("resultOutput");
const btn = document.getElementById("btn");

btn.addEventListener("click", (event) => checkLetters());
input.addEventListener("keyup", (event) => keyUp(event));

function keyUp(event) {
  e = e || window.event;
  if (e.keyCode == 13) {
    document.getElementById("btn").click();
    return false;
  }
  return true;
}

function checkLetters() {
  const inputTxt = input.value;

  if (/[a|b|c]+/gi.test(inputTxt)) {
    output.innerText =
      "Perfect! Your kitten's name is awesome and easily recognizable. For a better experience, remember to pronounce it with affection.";
  } else if (/[d|e|f]+/gi.test(inputTxt)) {
    output.innerText =
      "Good! Your kitten's name is great, and it is easy to recognize. Do not forget to reinforce the high-pitched syllables.";
  } else {
    output.innerText =
      "Not so good! Your kitten's name is lovely, but it may be difficult to recognize. Don't worry, you should keep this name and follow some of the tips below.";
  }
}

checkLetters(inputTxT);
