export class WorkerInfoDto {
    constructor(
    public workerInformationId?: number,
    public name?: string,
    public lastName?: string,
    public dataBirth?: Date,
    public passportSeries?: number,
    public passportNumber?: number,
    public experience?: number,
    public email?: string,
    public positionId?: number,
    public image?: string,
    public workerInformationImageId?: number
    ){}
}