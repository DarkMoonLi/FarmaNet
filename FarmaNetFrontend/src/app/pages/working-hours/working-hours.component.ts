import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { WorkingHourDto } from 'src/app/dto/working-hour.dto';
import { WorkingHourService } from 'src/app/services/working-hour.service';
import { WritedownService } from 'src/app/services/writedown.service';

@Component({
  selector: 'app-working-hours',
  templateUrl: './working-hours.component.html',
  styleUrls: ['./working-hours.component.scss']
})
export class WorkingHoursComponent implements OnInit {

  public workingHour!: WorkingHourDto;
  public workingHours!: WorkingHourDto[];                 // массив товаров
  public accountId: string | null = sessionStorage.getItem('accountId');

  constructor(private router: Router, private workingHourService: WorkingHourService) { }

  ngOnInit(): void {
    this.loadProducts()
  }

  loadProducts() {
    this.workingHourService.getWorkingHours(this.accountId)
      .subscribe((data: any) => this.workingHours = data);
  }

}
