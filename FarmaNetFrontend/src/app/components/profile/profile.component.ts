import { Component, OnInit } from '@angular/core';
import { WorkerInfoDto } from '../../dto/worker-info.dto';
import { Router } from '@angular/router';


@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})

export class ProfileComponent implements OnInit {
  // public data!: WorkerInfoDto;

  profile: WorkerInfoDto = {
    name: 'Ирина',
    lastName: 'Коскина',
    dataBirth: new Date(),
    passportSeries: 1234,
    passportNumber: 123456,
    experience: 800,
    email: 'sciraraider@gmail.com',
    positionId: 0
  }
  public data: WorkerInfoDto = this.profile;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  // datas: DrugDto = {
  //   name: 'Ибупрофен',
  //   description: 'Описание...',
  // };

}
