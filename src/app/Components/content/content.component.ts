import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  v1:number=0;
  v2:number=0;
  res:number=this.v1+this.v2;
  addFunc(){
    // let str1:string | null=" ";
    // let str2:string | null=" ";
    // this.v1=Number(prompt("enter the first number"));
    // this.v2=Number(prompt("enter the Second number"));
    
    // alert("adding two numbers is : "+this.res);
  }
}
