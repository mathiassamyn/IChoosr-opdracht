import { Component, OnInit } from '@angular/core';
import { combineLatest, Observable } from 'rxjs';
import { map, share } from 'rxjs/operators';
import { Camera } from '../../models/camera';
import { CameraService } from '../../services/camera.service';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.css']
})
export class OverviewComponent implements OnInit {

  cameras: Observable<Camera[]> = this.cameraService.getCameras().pipe(share());

  camerasThree: Observable<Camera[]> = this.cameras.pipe(map(cameras => cameras.filter(camera => camera.idIsDivisibleBy(3))));
  camerasFive: Observable<Camera[]> = this.cameras.pipe(map(cameras => cameras.filter(camera => camera.idIsDivisibleBy(5))));
  camerasThreeAndFive: Observable<Camera[]> = this.camerasFive.pipe(map(cameras => cameras.filter(camera => camera.idIsDivisibleBy(3))));
  camerasOverig: Observable<Camera[]> = this.cameras
    .pipe(map(cameras => cameras.filter(camera => !camera.idIsDivisibleBy(3) && !camera.idIsDivisibleBy(5))));

  constructor(private cameraService: CameraService) { }

  ngOnInit(): void {
  }

}
