export class WorkerInfoDto {
    constructor(
    public workerInformationId?: number,
    public name?: string,
    public lastName?: string,
    public dataBirth?: Date,
    public seriesPassport?: number,
    public numberPassport?: number,
    public experience?: number,
    public email?: string,
    public positionId?: number,
    public image?: string,
    ){}
}