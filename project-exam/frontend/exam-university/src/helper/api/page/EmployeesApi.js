import BaseApi from "../base/BaseApi";
import BaseApiConfig from "../base/BaseApiConfig";

class EmployeesApi extends BaseApi {
    /**
     * init constructor
     */
    constructor() {
        super();

        this.controller = "v1/Employees";
    }

    /**
     * function get employee code
     * @returns a new code employee
     * CreatedBy: PQ Huy (07.07.2021)
     */
    getNewEmployeeCode() {
        return BaseApiConfig.get(`${this.controller}/NewEmployeeCode`);
    }

    /**
     * function check new code
     * @param {code} employee code
     * @returns a true/false code exits
     * CreatedBy: PQ Huy (07.07.2021)
     */
    getCheckEmployeeCodeExist(code) {
        return BaseApiConfig.get(`${this.controller}/CheckEmployeeCodeExist/?code=${code}`);
    }

    /**
     * function get employee by email
     * @param {email} employee email
     * @returns a true/false code exits
     * CreatedBy: PQ Huy (07.07.2021)
     */
    getEmployeeByEmail(email) {
        return BaseApiConfig.get(`${this.controller}/Email/?email=${email}`);
    }

    /**
     * Function return total record
     * @returns employee total
     * CreatedBy: PQ Huy (08.07.2021)
     */
    getEmployeeTotal() {
        return BaseApiConfig.get(`${this.controller}/EmployeeTotal`);
    }

    /**
     * Function get employee filter
     * @param {int} pageIndex
     * @param {int} pageSize
     * @param {string} employeeFilter 
     * @returns list employee filter
     * CreatedBy: PQ Huy (08.07.2021)
     */
    getEmployeeFilter(pageIndex, pageSize, employeeFilter) {
        return BaseApiConfig.get(`${this.controller}/EmployeeFilter?pageIndex=${pageIndex}&pageSize=${pageSize}&employeeFilter=${employeeFilter}`);
    }

    /**
     * Function get paging employee
     * @param {int} pageIndex 
     * @param {int} pageSize 
     * @returns List employee paging
     * CreatedBy: PQ Huy (08.07.2021)
     */
    getEmployeePaging(pageIndex, pageSize) {
        return BaseApiConfig.get(`${this.controller}/EmployeePaging?pageIndex=${pageIndex}&pageSize=${pageSize}`);
    }

    /**
     * Function get all record after filter
     * @param {string} employeeFilter 
     * @returns All record filters
     * CreatedBy: PQ Huy (11.07.2021)
     */
    getEmployeeFilterAll(employeeFilter) {
        return BaseApiConfig.get(`${this.controller}/EmployeeFilterAll?employeeFilter=${employeeFilter}`);
    }

    /**
     * Function export data form api
     * @param {string} filterValue
     * CreatedBy: PQ Huy (15.07.2021)
     */
    exportDataApi(filterValue) {
        let queryString = `${this.controller}/Export${filterValue ? ('?&filterValue=' + filterValue) : ''}`;
        
        return BaseApiConfig.get(`${queryString}`, { responseType: 'blob' });
    }

    /**Function import data by excel
     * CreatedBy:  PQ Huy(20.07.2021)
     * @param {*} formData 
     * @returns 
     */
    importDataApi(formData) {
        debugger
        let keyCache = BaseApiConfig.post(`${this.controller}/import`, formData, {
            headers: {
                'Content-Type': 'multipart/form-data'
            }
        });

        if (keyCache) {
            return this.insertByKeyCache(keyCache);
        } else {
            return keyCache;
        }
    }
    
    /**
     * Api insert by key cache
     * @param {string} keyCache 
     * @returns reslue insert
     * CreatedBy:  PQ Huy (20.07.2021)
     */
    insertByKeyCache(keyCache) {
        return BaseApiConfig.post(`${this.controller}/${keyCache}`,);
    }

}

export default new EmployeesApi();