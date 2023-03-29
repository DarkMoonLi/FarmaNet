import { Component, Input, OnInit } from '@angular/core';
import { WorkingHourDto } from 'src/app/dto/working-hour.dto';

@Component({
  selector: 'app-working-hour',
  templateUrl: './working-hour.component.html',
  styleUrls: ['./working-hour.component.scss']
})
export class WorkingHourComponent implements OnInit {

  @Input() 
  workingHour!: WorkingHourDto;

  constructor() { }

  ngOnInit(): void {
  }

}
