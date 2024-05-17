using Integrador.Domain.OnBloxConfigure;

namespace Integrador.Repository.OnBloxConfigure
{
    public interface IOnBloxConfigureRepository
    {
        OnBloxConfigureModel Add(IOnBloxConfigureModel model);
        OnBloxConfigureModel GetOnBloxConfigure();
        OnBloxConfigureModel Update(IOnBloxConfigureModel model);
    }
}