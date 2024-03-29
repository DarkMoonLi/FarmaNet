import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PharmacyDto } from 'src/app/dto/pharmacy.dto';
import { PositionDto } from 'src/app/dto/position.dto';
import { WorkerImageDto } from 'src/app/dto/worker-image.dto';
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
  workerImage: WorkerImageDto = new WorkerImageDto();

  loadProduct() {
    this.workerInfoService.getWorker(this.id)
      .subscribe((data: any) => this.worker = data);
    this.workerInfoService.getPharmacy(this.id)
      .subscribe((data:any) => this.pharmacy = data);
    this.workerInfoService.getPosition(this.id)
      .subscribe((data:any) => this.position = data);
    this.workerInfoService.getImage(this.id)
      .subscribe((data:any) => {this.workerImage = data; console.log(data);});
  }

  modalActive: boolean = false;
  modalUpdateActive: boolean = false;

  selectedFile!: File;

  onFileSelected(event: any): void {
    this.selectedFile = event.target.files[0];
  }

  handleFileInput(form: any): void {
    const formData = new FormData();
    formData.append('uploadedFile', this.selectedFile, this.selectedFile.name);

    this.workerInfoService.sendImage(formData).subscribe((data: any) => this.workerImage = data);
    this.closeModal()
  }

  openModal() {
    this.modalActive = true;
  }

  closeModal() {
    this.modalActive = false;
  }

  openUpdateModal() {
    this.modalUpdateActive = true;
  }

  closeUpdateModal() {
    this.modalUpdateActive = false;
  }

  sendData() {
    const Data = {
      WorkerInformationId: this.worker.workerInformationId,
      Name: this.worker.name,
      LastName: this.worker.lastName,
      DataBirth: this.worker.dataBirth,
      SeriesPassport: this.worker.passportSeries,
      NumberPassport: this.worker.passportNumber,
      Experience: this.worker.experience,
      Email: this.worker.email,
      PositionId: this.worker.positionId,
      WorkerInformationImageId: this.workerImage.imageId
    }
    this.workerInfoService.updateData(Data)
      .subscribe((data:any) => this.position = data);
  }
}
