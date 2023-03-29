import { TestBed } from '@angular/core/testing';

import { WritedownService } from './writedown.service';

describe('WritedownService', () => {
  let service: WritedownService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WritedownService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
