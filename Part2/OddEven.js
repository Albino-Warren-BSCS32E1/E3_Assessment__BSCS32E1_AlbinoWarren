function checkEvenOrOdd() {
    var number = parseInt(prompt("Enter a number:"));
  
    if (number % 2 === 0) {
      document.getElementById("resultParagraph").innerText = number + " is even.";
    } else {
      document.getElementById("resultParagraph").innerText = number + " is odd.";
    }
  }