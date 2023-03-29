import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';
import { PositionDto } from 'src/app/dto/position.dto';
import { WorkerInfoDto } from 'src/app/dto/worker-info.dto';
import { WorkerInfoService } from 'src/app/services/worker-info.service';

@Component({
  selector: 'app-worker-info',
  templateUrl: './worker-info.component.html',
  styleUrls: ['./worker-info.component.scss']
})
export class WorkerInfoComponent implements OnInit {

  constructor(private workerInfoService: WorkerInfoService, private route: ActivatedRoute) { }

  id: string | null = localStorage.getItem('workerInformationId');

  ngOnInit(): void {
    this.loadProduct();
  }

  worker: WorkerInfoDto = new WorkerInfoDto();
  pharmacy: PharmacyDto = new PharmacyDto();
  position: PositionDto = new PositionDto();

  loadProduct() {
    this.workerInfoService.getWorker(this.id)
      .subscribe((data: any) => this.worker = data);
    this.workerInfoService.getPharmacy(this.id)
      .subscribe((data:any) => this.pharmacy = data);
    this.workerInfoService.getPosition(this.id)
      .subscribe((data:any) => this.position = data);
  }

  modalActive: boolean = false;

  handleFileInput(event: any): void {
    const file: File = event.target.files[0];
  
    const formData = new FormData();
    formData.append('uploadedFile', file);
    this.workerInfoService.sendImage(formData);
    this.closeModal()
  }

  openModal() {
    this.modalActive = true;
  }

  closeModal() {
    this.modalActive = false;
  }
}
