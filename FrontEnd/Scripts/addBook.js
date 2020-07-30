function addBook(){
    var title = document.getElementById("title").value;
    var author = document.getElementById("author").value;
    var pages = document.getElementById("pages").value;
    var price = document.getElementById("price").value;
    var amount = document.getElementById("amount").value;
    var town = document.getElementById("town").value;
    var year = document.getElementById("year").value;
    var planet = document.getElementById("planet").value;
    // console.log(title);
    // console.log(author);
    // console.log(pages);
    // console.log(price);
    
    axios.post('https://localhost:44384/api/book/create', {
        title: title,
        author: author,
        pages: parseInt(pages),
        price: parseInt(price),
        amount: parseInt(amount),
        town: town,
        year: parseInt(year),
        planet: planet
      })
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
}

function toggle(event){
    console.log(event.target.value)
    if (event.target.value == "history") {
        document.getElementById("history").classList.remove("hide");
        document.getElementById("fantasy").classList.add("hide");
        document.getElementById("classic").classList.add("hide");
    }else if (event.target.value == "classic") {
        document.getElementById("classic").classList.remove("hide");
        document.getElementById("fantasy").classList.add("hide");
        document.getElementById("history").classList.add("hide");
    }else if (event.target.value == "fantasy") {
        document.getElementById("fantasy").classList.remove("hide");
        document.getElementById("classic").classList.add("hide");
        document.getElementById("history").classList.add("hide");
    }
}

