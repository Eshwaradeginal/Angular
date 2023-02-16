import { Component, OnInit } from '@angular/core';
import { Employee } from '../../employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit{
  employee:Employee[]=[];
  toShow : number = 0;
  btnMessage : string ="Add Employee";

  SelectedEmp:Employee={} as Employee;
  
  ngOnInit(): void {
    this.employee.push({id:123,Name:"Eshwar",Address:"davanegere",Salary:45000,Image:"../assets/Images/skoda.jpg"});
    this.employee.push({id:123,Name:"Eshwar",Address:"davanegere",Salary:45000,Image:"../assets/Images/kia.jfif"});
    this.employee.push({id:123,Name:"Eshwar",Address:"davanegere",Salary:45000,Image:"../assets/Images/kia.jfif"});
    this.employee.push({id:123,Name:"Eshwar",Address:"davanegere",Salary:45000,Image:"../assets/Images/kia.jfif"});
    this.employee.push({id:123,Name:"Eshwar",Address:"davanegere",Salary:45000,Image:"../assets/Images/kia.jfif"});
  }

  onEdit(emp:Employee){
    
      this.SelectedEmp=emp;

      
  }
  onDeleteHandler(emp:Employee){
    debugger;
        let index=this.employee.indexOf(emp);
        this.employee.splice(index,1);
        
  }
  onShow(){
    this.toShow =  this.toShow === 0 ? 1 : 0;
    if(this.toShow == 1)
      this.btnMessage = "Cancel Adding";
      else this.btnMessage = "Add Employee";
  }
  onAddHandler(emp : Employee){
    debugger;
    this.employee.push(emp);
    this.employee = this.employee.slice();
  }


}
