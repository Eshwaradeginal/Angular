import { Component } from '@angular/core';


@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  val1:number=0.0;
  val2:number=0.0;
  operand:string="";
  res:number=0.0;
  onSubmit(){
    alert("hai")
    switch (this.operand) {
      case "+": this.res=this.val1 + this.val2;break;
      case "-": this.res=this.val1 - this.val2;break;
      case "X": this.res=this.val1 * this.val2;break;
      case "/": this.res=this.val1 / this.val2;break; 
      
    }
  }
}
