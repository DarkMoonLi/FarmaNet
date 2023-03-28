export class ImportDto {
        constructor(
                public ImportId?: number,
                public Number?: string,
                public Date?: string,
                public SumPrice?: number,
                public SupplierId?: number,
                public PharmacyId?: number,) {}
}