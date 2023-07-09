import { NgModule } from "@angular/core";
import { CommonModule, DatePipe } from "@angular/common";
import { AdminRoutingModule } from "./admin-routing.module";
//import { AddDepartmentComponent } from './departments/add-department/add-department.component';
//import { AddPositionsComponent } from './positions/add-positions/add-positions.component';

@NgModule({
  declarations: [
  ],
  imports: [CommonModule, AdminRoutingModule],
  providers: [DatePipe]
})
export class AdminModule {}
