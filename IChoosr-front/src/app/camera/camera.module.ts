import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CameraService } from './services/camera.service';
import { OverviewComponent } from './components/overview/overview.component';



@NgModule({
  declarations: [OverviewComponent],
  providers: [CameraService],
  imports: [
    CommonModule
  ],
  exports: [
    OverviewComponent
  ]
})
export class CameraModule { }
