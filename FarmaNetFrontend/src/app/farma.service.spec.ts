import { TestBed } from '@angular/core/testing';

import { FarmaService } from './farma.service';

describe('FarmaService', () => {
  let service: FarmaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FarmaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
