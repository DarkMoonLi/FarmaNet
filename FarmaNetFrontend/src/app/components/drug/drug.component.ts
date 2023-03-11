import { Component, OnInit } from '@angular/core';
import { DrugDto } from 'src/app/dto/drug.dto';
import { Input } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-drug',
  templateUrl: './drug.component.html',
  styleUrls: ['./drug.component.scss']
})
export class DrugComponent implements OnInit {

  @Input() Drug!: DrugDto;

  constructor(private router: Router) {  }

  ngOnInit(): void {
  }

  goToDrugId(drugId: number| undefined)
  {
    this.router.navigate(['/drug/:id', {id: drugId}])
  }
}
