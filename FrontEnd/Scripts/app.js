axios.get('https://localhost:44384/api/book')
  .then(function (response) {
    var historyBooks = response.data.historyBooks;
    var classicBooks = response.data.classicBooks;
    var fantasyBooks = response.data.fantasyBooks;
    console.log(historyBooks);
    console.log(classicBooks);
    console.log(fantasyBooks);

   displayHistoryBooks(historyBooks);
   displayClassicBooks(classicBooks);
   displayFantasyBooks(fantasyBooks);
  })
  .catch(function (error) {
    console.log(error);
  });

function displayHistoryBooks(arr){
    var historyBookContainer = document.getElementById("historyBookContainer");
    arr.forEach(book => {
        var card = document.createElement("div");
        card.classList.add("card");
        card.style.width = "18rem";
        historyBookContainer.appendChild(card);

        var cardBody = document.createElement("div");
        cardBody.classList.add("card-body");
        card.appendChild(cardBody);

        var cardTitle = document.createElement("h5");
        cardTitle.classList.add("card-title");
        cardTitle.innerText = book.title;
        cardBody.appendChild(cardTitle);

        var cardSubtitle = document.createElement("h6");
        cardSubtitle.className = "card-subtitle mb-2 text-muted";
        cardSubtitle.innerText = book.author;
        cardBody.appendChild(cardSubtitle);

        var cardPrice = document.createElement("p");
        cardPrice.classList.add("card-text");
        cardPrice.innerText = `Price $${book.price}`
        cardBody.appendChild(cardPrice);

        var cardType = document.createElement("p");
        cardType.classList.add("card-text");
        cardType.innerText = `Type: History`
        cardBody.appendChild(cardPrice);

        var cardYear = document.createElement("p");
        cardYear.classList.add("card-text");
        cardYear.innerText = `Year: ${book.year}`;
        cardBody.appendChild(cardYear);
    });
}

function displayClassicBooks(arr){
    var historyBookContainer = document.getElementById("classicBookContainer");
    arr.forEach(book => {
        var card = document.createElement("div");
        card.classList.add("card");
        card.style.width = "18rem";
        historyBookContainer.appendChild(card);

        var cardBody = document.createElement("div");
        cardBody.classList.add("card-body");
        card.appendChild(cardBody);

        var cardTitle = document.createElement("h5");
        cardTitle.classList.add("card-title");
        cardTitle.innerText = book.title;
        cardBody.appendChild(cardTitle);

        var cardSubtitle = document.createElement("h6");
        cardSubtitle.className = "card-subtitle mb-2 text-muted";
        cardSubtitle.innerText = book.author;
        cardBody.appendChild(cardSubtitle);

        var cardPrice = document.createElement("p");
        cardPrice.classList.add("card-text");
        cardPrice.innerText = `Price $${book.price}`
        cardBody.appendChild(cardPrice);

        var cardType = document.createElement("p");
        cardType.classList.add("card-text");
        cardType.innerText = `Type: Classic`
        cardBody.appendChild(cardPrice);

        var cardTown = document.createElement("p");
        cardTown.classList.add("card-text");
        cardTown.innerText = `Town: ${book.town}`;
        cardBody.appendChild(cardTown);
    });
}

function displayFantasyBooks(arr){
    var historyBookContainer = document.getElementById("fantasyBookContainer");
    arr.forEach(book => {
        var card = document.createElement("div");
        card.classList.add("card");
        card.style.width = "18rem";
        historyBookContainer.appendChild(card);

        var cardBody = document.createElement("div");
        cardBody.classList.add("card-body");
        card.appendChild(cardBody);

        var cardTitle = document.createElement("h5");
        cardTitle.classList.add("card-title");
        cardTitle.innerText = book.title;
        cardBody.appendChild(cardTitle);

        var cardSubtitle = document.createElement("h6");
        cardSubtitle.className = "card-subtitle mb-2 text-muted";
        cardSubtitle.innerText = book.author;
        cardBody.appendChild(cardSubtitle);

        var cardPrice = document.createElement("p");
        cardPrice.classList.add("card-text");
        cardPrice.innerText = `Price $${book.price}`
        cardBody.appendChild(cardPrice);

        var cardType = document.createElement("p");
        cardType.classList.add("card-text");
        cardType.innerText = `Type: Fantasy`
        cardBody.appendChild(cardPrice);

        var cardPlanet = document.createElement("p");
        cardPlanet.classList.add("card-text");
        cardPlanet.innerText = `Planet: ${book.planet}`;
        cardBody.appendChild(cardPlanet);
    });
}