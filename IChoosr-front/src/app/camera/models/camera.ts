import { ICameraDto } from '../interfaces/camera.dto';

export class Camera {
    id: number;
    name: string;
    latitude: number;
    longitude: number;

    constructor(camera: ICameraDto) {
        this.id = camera.id;
        this.latitude = camera.latitude;
        this.longitude = camera.longitude;
        this.name = camera.name;
    }

    idIsDivisibleBy(divider: number): boolean {
        return this.id % +divider === 0;
    }
}
