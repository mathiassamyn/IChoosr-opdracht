import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ICameraDto } from '../interfaces/camera.dto';
import { Camera } from '../models/camera';
import { map } from 'rxjs/operators';

@Injectable()
export class CameraService {

  CONTROLLER = 'camera';

  constructor(private httpCLient: HttpClient) { }

  getCameras(): Observable<Camera[]> {
    return this.httpCLient.get<ICameraDto[]>(`${environment.apiEndpoint}/${this.CONTROLLER}/all`)
      .pipe(map(res => res.map(camera => new Camera(camera))));
  }
}
