const card = document.getElementsByClassName("card");
const btnAdd = document.getElementsByClassName("btn-add");
const cartList = document.querySelector(".shopping-cart-list");

class Shopping {
    constructor(image, title, price, id, type) {
        this.image = image;
        this.title = title;
        this.price = price;
        this.id = id;
        this.type = type;
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
                    <p class="id" hidden>${shopping.id}</p>
                    <p class="type" hidden>${shopping.type}</p>
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
            itemCount.textContent = `(${cartListItem.length})`;
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

                let newPrice = price.replace("$", "");
                newPrice = parseFloat(newPrice);

                totalAmount += newPrice;
            }

            totalAmountDiv.classList = "total-amount";
            totalAmountDiv.innerHTML =
                `
                <hr><h5 class="text-center text-primary">Total Amount: <p class="text-dark" style="display:inline;">$${totalAmount}</p></h5>
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
                    let id = item.querySelector(".id").textContent;
                    let type = item.querySelector(".type").textContent;
                    let image = item.querySelector("img").src;
                    items.push({ title: title, price: price, image: image, id: id, type: type });
                }

                if (!items.some(item => item.type.trim() === "Menu")) {
                    
                    // Mevcut bir alert div varsa kaldır
                    let existingAlertDiv = document.querySelector(".alert");
                    if (existingAlertDiv) {
                        existingAlertDiv.remove();
                    }

                    // Sepetin içinde Menü eklenmemişse uyarı ver. 
                    let alertDiv = document.createElement("div");
                    alertDiv.className = "alert alert-danger mt-3";
                    alertDiv.role = "alert";
                    alertDiv.innerHTML = "Menüyü eklemeden sipariş veremezsiniz.";

                    // Uyarı mesajını belirtilen div'den sonra ekle
                    let cartDiv = document.querySelector(".btn-order");
                    cartDiv.parentNode.insertBefore(alertDiv, cartDiv.nextSibling);

                    return; // Metodu kırıp formun gönderilmesini engelle.
                }

                // Verileri JSON formatında OrderController / Submit action'una gönderir
                let form = document.createElement("form");
                form.method = "POST";
                form.action = "/Order/Submit"; // Gidecek controller ve action

                let input = document.createElement("input");
                input.type = "hidden";
                input.name = "orderData"; // action'un parametresine gider.
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
        let elements = card[i].getElementsByTagName("p");
        let type;

        // elements HTMLCollection olduğundan, döngü ile kontrol edilir
        for (let j = 0; j < elements.length; j++) {
            let element = elements[j];

            if (element.classList.contains("menu-card")) {
                type = element.textContent;
                break; // uygun sınıf bulundu, döngüden çık
            } else if (element.classList.contains("extraItem-card")) {
                type = element.textContent;
                break; // uygun sınıf bulundu, döngüden çık
            }
        }

        let title = card[i].getElementsByClassName("card-title")[0].textContent;
        let price = card[i].getElementsByClassName("card-price")[0].textContent;
        let id = card[i].getElementsByClassName("card-id")[0].textContent;
        let image = card[i].getElementsByClassName("card-image")[0].src;

        let shopping = new Shopping(image, title, price, id, type);

        let ui = new UI();

        ui.addToCart(shopping);
        ui.removeCart();
        ui.cartCount();
        ui.totalAmount();

        event.preventDefault();
    });
}
