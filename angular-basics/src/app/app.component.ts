import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  //title:string = 'Angular-Basics';
  email:string = 'brunda@gmail.com'
  password:string ='123@brunda'
  titleOne:string ="One way data binding"
  titleTwo:string = "Two way data binding"
  imageUrl:string='../assets/tom.jpg'
  imageWidth= 120
  imageHeight= 120


  save(){
    console.log('email address: ',this.email);
    console.log('password: ',this.password);

  }
}
