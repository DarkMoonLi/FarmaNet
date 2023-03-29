export class PharmacyDto {
  constructor(
    public pharmacyId?: number,
    public name?: string,
    public address?: string,
    public image?: string,
    public email?: string,
    public description?: string,
  ){}
}