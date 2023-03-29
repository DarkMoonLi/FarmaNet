import { TestBed } from '@angular/core/testing';

import { DrugInfoService } from './drug-info.service';

describe('DrugInfoService', () => {
  let service: DrugInfoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DrugInfoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
