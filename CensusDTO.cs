using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public string stateCode;
        public int tin;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode=stateCodeDao.stateCode;
        }

        public CensusDTO(censusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }

        //public CensusDTO(USCensusDAO usCensusDAO)
        //{
        //    this.stateCode = usCensusDAO.stateCode;
        //    this.totalArea = usCensusDAO.totalArea;
        //    this.landArea = usCensusDAO.landArea;   
        //    this.waterArea = usCensusDAO.waterArea;
        //    this.population = usCensusDAO.population;
        //    this.housingUnits = usCensusDAO.housingUnits;
        //    this.stateName = usCensusDAO.stateName;
        //}
    }

   
}
