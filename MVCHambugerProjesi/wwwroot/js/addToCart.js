const card = document.getElementsByClassName("card");
const btnAdd = document.getElementsByClassName("btn-add");
const cartList = document.querySelector(".shopping-cart-list");

class Shopping {
    constructor(image, title, price) {
        this.image = image;
        this.title = title;
        this.price = price;
    }
}
class UI {
    addToCart(shopping) {
        const listItem = document.createElement("div");
        listItem.classList = "list-item"; // div'in içine "list-item" adında class ekler.
        listItem.innerHTML =
            `
                <div class="row align-items-center text-primary-50">
                    <div class="col-md-3">
                        <img src="${shopping.image}" alt="product"
                            class="img-fluid">
                    </div>
                    <div class="col-md-5">
                        <div class="title">${shopping.title}</div>
                    </div>
                    <div class="col-md-2">
                        <div class="price" data-price="${shopping.price}">${shopping.price}</div>
                    </div>
                    <div class="col-md-2">
                        <button class="btn btn-delete text-danger">
                            <i class="bi bi-trash-fill"></i>
                        </button>
                    </div>
                </div>
            `;
        cartList.appendChild(listItem);
    }

    removeCart() {
        let btnRemove = document.getElementsByClassName("btn-delete");
        let self = this; // cartCount() kullanabilmek için gerekli.
        for (let i = 0; i < btnRemove.length; i++) {
            btnRemove[i].addEventListener("click", function () {
                this.parentElement.parentElement.parentElement.remove();
                self.cartCount();
                self.totalAmount();
            });
        }
    }

    cartCount() {
        let cartListItem = cartList.getElementsByClassName("list-item");
        let itemCount = document.getElementById("item-count");
        if (itemCount) {
            itemCount.innerHTML = cartListItem.length;
        }
    }

    totalAmount() {
        let totalAmount = 0;
        let cartListItem = cartList.getElementsByClassName("list-item");
        const totalAmountDiv = document.createElement("div");

        if (cartListItem.length > 0) {
            for (let i = 0; i < cartListItem.length; i++) {
                let priceElement = cartListItem[i].getElementsByClassName("price")[0];
                let price = priceElement.getAttribute("data-price");

                let newPrice = price.replace("₺", "");
                newPrice = parseFloat(newPrice);

                totalAmount += newPrice;
            }

            totalAmountDiv.classList = "total-amount";
            totalAmountDiv.innerHTML =
            `
                <hr><h5 class="text-center text-primary">Total Amount: <p class="text-dark" style="display:inline;">₺${totalAmount}</p></h5>
                <button class="btn btn-delete text-danger btn-order"><i class="bi bi-arrow-up-right-square-fill"></i>Sipariş Ver</button>
            `;

            let existingTotalAmountDiv = cartList.querySelector(".total-amount");
            if (existingTotalAmountDiv) {
                existingTotalAmountDiv.remove(); // Eski totalAmountDiv'i kaldır
            }

            cartList.appendChild(totalAmountDiv);

            // Sipariş Ver butonuna tıklama olayını ekle
            document.querySelector(".btn-order").addEventListener("click", function (event) {
                // Sepet verilerini toplama
                let items = [];
                let listItems = cartList.getElementsByClassName("list-item");
                for (let i = 0; i < listItems.length; i++) {
                    let item = listItems[i];
                    let title = item.querySelector(".title").textContent;
                    let price = item.querySelector(".price").textContent;
                    let image = item.querySelector("img").src;
                    items.push({ title: title, price: price, image: image });
                }

                // Toplanan verileri JSON formatında bir formda gönderme
                let form = document.createElement("form");
                form.method = "POST";
                form.action = "/Order/Submit"; // Siparişlerin gönderileceği sayfa

                let input = document.createElement("input");
                input.type = "hidden";
                input.name = "orderData";
                input.value = JSON.stringify(items);
                form.appendChild(input);

                document.body.appendChild(form);
                form.submit();
            });
        } else {
            // Eğer listede öğe yoksa ve totalAmountDiv zaten eklendiyse kaldır
            let existingTotalAmountDiv = cartList.querySelector(".total-amount");
            if (existingTotalAmountDiv) {
                existingTotalAmountDiv.remove();
            }
        }
    }
}

for (let i = 0; i < btnAdd.length; i++) {
    btnAdd[i].addEventListener("click", function (event) {
        let title = card[i].getElementsByClassName("card-title")[0].textContent;
        let price = card[i].getElementsByClassName("card-price")[0].textContent;
        let image = card[i].getElementsByClassName("card-image")[0].src;

        let shopping = new Shopping(image, title, price);

        let ui = new UI();

        ui.addToCart(shopping);
        ui.removeCart();
        ui.cartCount();
        ui.totalAmount();

        event.preventDefault();
    });
}
