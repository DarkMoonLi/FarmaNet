export class DrugInfoDto {
  constructor(
      public id?: number,
      public name?: string,
      public price?: string,
      public indicationsForUse?: string,
      public compositions?: string,
      public contraindications?: string,
      public instruction?: string,
      public medicationTypeId?: number, 
      public medicationImageId?: number
      ){}
  }