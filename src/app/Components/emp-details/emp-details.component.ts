import { Component, Input, EventEmitter, Output } from '@angular/core';
import { Employee } from '../../employee';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styleUrls: ['./emp-details.component.css']
})
export class EmpDetailsComponent {
  @Input() SelectedEmp: Employee = {} as Employee;

  @Output() onDelete: EventEmitter<Employee> = new EventEmitter<Employee>();
  @Output() onupDate: EventEmitter<Employee> = new EventEmitter<Employee>();

  invokeEmp() {
    
    this.onDelete.emit(this.SelectedEmp);
    this.SelectedEmp = {} as Employee;
    

  }

  invokUpdate(emp:Employee){
    
    emp.id=this.SelectedEmp.id;
    emp.Name=this.SelectedEmp.Name;
    emp.Address=this.SelectedEmp.Address;
    emp.Salary=this.SelectedEmp.Salary;
    alert("updated");
    this.onupDate.emit(this.SelectedEmp);
  }

}
