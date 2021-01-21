import { Camera } from './camera';

describe('Camera', () => {
  describe('isDivisibleBy', () => {
    let camera: Camera;

    beforeEach(() => {
      camera = new Camera({
        id: 5,
        name: 'test',
        latitude: 43,
        longitude: 34
      });
    });

    it('It should return true', () => {
      const result = camera.idIsDivisibleBy(5);
      expect(result).toBeTrue();
    });

    it('It should return false', () => {
      const result = camera.idIsDivisibleBy(2);
      expect(result).toBeFalse();
    });
  });
});
