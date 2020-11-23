document.addEventListener('DOMContentLoaded', () => {
    const button = document.querySelector(".loadingButton");
    button.addEventListener("click", (event)=> {
        loadItems();
        button.disabled = true;
        })
    })
let items = [];

function loadItems(){
    console.log("Load items");

    fetch('assets/data/shopping-list.json')
    .then((response) => {
        return response.json();
    })
    .then((data) => {
        items = data;
        displayItems();
    })
    .catch((err) => console.error(err));
}

function displayItems() {
    console.log("Display items");

    const li = document.querySelector("li");
    if(li != null) {
        alert("Not loading")
        return;
    }

    if('content' in document.createElement('template')) {
        const ul = document.querySelector("ul");
        items.forEach((item) => {
            const template = document.getElementById('shopping-list-item-template').content.cloneNode(true);
            template.querySelector("li").insertAdjacentHTML('afterbegin', item.name);
            if(item.completed) {
                const check = template.querySelector('i');
                check.className += " completed";
            }
            ul.appendChild(template);
        });
    } else {
        console.error("Your browser doesn't support Templates");
    }
}

