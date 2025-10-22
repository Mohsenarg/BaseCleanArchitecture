using SharedKernel;

namespace Domain.BaseEntitys;

public sealed record BaseEntityItemCreatedDomainEvent(Guid BaseEntityItemId) : IDomainEvent;
