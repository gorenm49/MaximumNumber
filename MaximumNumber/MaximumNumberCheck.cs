namespace MaximumNumber
{
    public class MaximumNumberCheck
    {
        
        public int MaxNumCheck(float fNum, float secNum, float thirNum)
        {
            if (fNum.CompareTo(secNum)>0 && fNum.ComapareTo(thirNum)>0)
            {
                return fNum;
            }
            if (secNum.CompareTo(fNum)>0 && secNum.ComapareTo(thirNum)>0)
            {
                return secNum;
            }
            else
            {
                return thirNum;
            }
        }
    }
}