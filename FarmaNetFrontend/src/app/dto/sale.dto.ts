export class SaleDto {
  constructor(
    public medicationName?: string,
    public price?: string,
    public quantity?: number,
    public sum?: string,
  ){}
}