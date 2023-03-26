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
    Name: 'Ирина',
    LastName: 'Коскина',
    DataBirth: new Date(),
    SeriesPassport: 1234,
    NumberPassport: 123456,
    Experience: 800,
    Email: 'sciraraider@gmail.com',
    PositionId: 0
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
