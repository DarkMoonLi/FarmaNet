import { Time } from "@angular/common";

export class WorkingHourDto {
  constructor(
    public date?: Date,
    public time?: Time,
    public description?: string){}
  }