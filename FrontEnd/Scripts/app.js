axios.get('https://localhost:44384/api/book')
  .then(function (response) {
    var historyBooks = response.data.historyBooks;
    var classicBooks = response.data.classicBooks;
    var fantasyBooks = response.data.fantasyBooks;

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

        var deleteBtn = document.createElement("div");
        deleteBtn.className = "btn btn-danger btn-sm";
        deleteBtn.innerText = "delete";
        deleteBtn.id = book.id;
        deleteBtn.onclick = function(event){
            axios.delete(`https://localhost:44384/api/book/delete/${event.target.id}/History`, )
            .then(function(){
                location.href = "./index.html"
            })
            .catch((error) => {
              throw error.response.data
            })
        }
        cardBody.appendChild(deleteBtn);

        var updateBtn = document.createElement("div");
        updateBtn.className = "btn btn-success btn-sm";
        updateBtn.innerText = "Update";
        updateBtn.id = book.id;
        updateBtn.style.marginLeft = "10px";
        updateBtn.onclick = function(){
            location.href = "./updateBook.html"
        }
        cardBody.appendChild(updateBtn);
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
        

        var deleteBtn = document.createElement("div");
        deleteBtn.className = "btn btn-danger btn-sm";
        deleteBtn.innerText = "delete";
        deleteBtn.id = book.id;
        deleteBtn.onclick = function(event){
            axios.delete(`https://localhost:44384/api/book/delete/${event.target.id}/Classic`, )
            .then(function(){
                location.href = "./index.html"
            })
            .catch((error) => {
              throw error.response.data
            })
        }
        cardBody.appendChild(deleteBtn);

        var updateBtn = document.createElement("div");
        updateBtn.className = "btn btn-success btn-sm";
        updateBtn.innerText = "Update";
        updateBtn.id = book.id;
        updateBtn.style.marginLeft = "10px";
        updateBtn.onclick = function(){
            location.href = "./updateBook.html"
        }
        cardBody.appendChild(updateBtn);
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

        var deleteBtn = document.createElement("div");
        deleteBtn.className = "btn btn-danger btn-sm";
        deleteBtn.innerText = "delete";
        deleteBtn.id = book.id;
        deleteBtn.onclick = function(event){
            axios.delete(`https://localhost:44384/api/book/delete/${event.target.id}/Fantasy`, )
            .then(function(){
                location.href = "./index.html"
            })
            .catch((error) => {
              throw error.response.data
            })
        }
        cardBody.appendChild(deleteBtn);

        var updateBtn = document.createElement("div");
        updateBtn.className = "btn btn-success btn-sm";
        updateBtn.style.marginLeft = "10px";
        updateBtn.innerText = "Update";
        updateBtn.id = book.id;
        updateBtn.onclick = function(){
            location.href = "./updateBook.html"
        }
        cardBody.appendChild(updateBtn);
    });
}

