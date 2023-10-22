import { Component } from "@angular/core";

@Component({
    selector: 'app-productlist',
    templateUrl: './productlist.component.html',
    
})


export class ProductListComponent{
    title:string= 'Electronic Products'
    
    products=[
        {
            productName:'Mobile',
            imageUrl:'./assets/mobile.jpg',
            productPrice:'Rs 35,000',
            productDescription:'OnePlus Nord CE 5G. 64 MP triple camera. Warp Charge 30T Plus + 4500mAh battery. 90 Hz AMOLED display and Snapdragon TM 750G 5G.',
            isVisible:false

        },
        {
            productName:'Smartwatch',
            imageUrl:'./assets/watch.jpg',
            productPrice:'Rs 4,000',
            productDescription:'The first smartwatch with Wear OS Powered by Samsung, Galaxy Watch4 puts seamless access to your favorite apps on your wrist.',
            isVisible:false
        },
        {
            productName:'Airpods',
            imageUrl:'./assets/Airpods.jpg',
            productPrice:'Rs 15,000',
            productDescription:'AirPods deliver an unparalleled wireless headphone experience, from magical setup to high-quality sound.',
            isVisible:false
        },


        ];

        showHide(index:number){
            this.products[index].isVisible=!this.products[index].isVisible;
        }
    }